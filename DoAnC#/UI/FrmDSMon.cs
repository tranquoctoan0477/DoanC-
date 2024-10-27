using DoAnC_.BLL;
using DoAnC_.DAL;
using DoAnC_.UI.UI_UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_.UI
{
    public partial class FrmDSMon : Form
    {
        public FrmDSMon()
        {
            InitializeComponent();
            ClsKetNoi.getConectionString();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                List<ClsProduct> products = ClsProduct.GetAllProducts();
                Debug.WriteLine($"Số lượng sản phẩm lấy được: {products.Count}");
                flPanDSTD.Controls.Clear();

                if (products.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào để hiển thị.");
                    return;
                }

                foreach (var product in products)
                {
                    try
                    {
                        ButtonProduct buttonProduct = new ButtonProduct
                        {
                            ProductName = product.Title,
                            ProductPrice = product.Price != 0 ? product.Price.ToString("N0", CultureInfo.InvariantCulture) + " VND" : "Không có giá"
                        };
                        Debug.WriteLine($"Tên sản phẩm: {product.Title}, Giá: {product.Price}");

                        // Xác định đường dẫn tới thư mục gốc của dự án
                        string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;

                        // Tạo đường dẫn đầy đủ tới ảnh từ thư mục img\img_sanpham
                        string imagePath = Path.Combine(projectDirectory, product.Thumbnail.Replace("/", "\\"));
                        Debug.WriteLine($"Đường dẫn ảnh đã chỉnh sửa: {imagePath}");

                        // Kiểm tra và tải hình ảnh từ đường dẫn
                        if (!string.IsNullOrEmpty(product.Thumbnail) && File.Exists(imagePath))
                        {
                            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                buttonProduct.ProductImage = new Bitmap(fs);
                            }
                            Debug.WriteLine($"Đã tải ảnh cho sản phẩm: {product.Title}");
                        }
                        else
                        {
                            // Sử dụng ảnh mặc định từ tài nguyên nếu không có ảnh
                            buttonProduct.ProductImage = Properties.Resources.macdinh;
                            Debug.WriteLine($"Sử dụng ảnh mặc định cho sản phẩm: {product.Title}");
                        }

                        flPanDSTD.Controls.Add(buttonProduct);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xử lý sản phẩm: {product.Title}. Chi tiết lỗi: {ex.Message}");
                        Debug.WriteLine($"Lỗi khi xử lý sản phẩm: {product.Title}. Chi tiết lỗi: {ex}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách sản phẩm. Chi tiết lỗi: {ex.Message}");
                Debug.WriteLine($"Lỗi khi lấy danh sách sản phẩm. Chi tiết lỗi: {ex}");
            }
        }

        private void FrmDSMon_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 655);
        }
    }
}
