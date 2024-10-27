using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_.UI.UI_UserControl
{
    public partial class ButtonProduct : UserControl
    {
        public ButtonProduct()
        {
            InitializeComponent();
        }

        public new string ProductName
        {
            get { return lbltenSP.Text; }
            set { lbltenSP.Text = value; }
        }

        public string ProductPrice
        {
            get { return lblgiaSP.Text; }
            set
            {
                // Hiển thị "Không có giá" nếu giá trị là null hoặc chuỗi trống
                lblgiaSP.Text = !string.IsNullOrEmpty(value) ? value : "Không có giá";
            }
        }

        public Image ProductImage
        {
            get { return pictSP.Image; }
            set
            {
                if (value != null)
                {
                    pictSP.Image = value;
                }
                else
                {
                    // Sử dụng ảnh mặc định từ tài nguyên nếu không có ảnh
                    pictSP.Image = Properties.Resources.macdinh;

                }
            }
        }



    }
}
