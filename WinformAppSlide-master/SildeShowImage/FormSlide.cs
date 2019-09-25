using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SildeShowImage
{
    public partial class FormSlide : Form
    {
        private int imageNumber = 1;

        public FormSlide()
        {
            InitializeComponent();
        }

        private void loadNextImage()
        {
            if (imageNumber > 10)
            {
                imageNumber = 1;
            }
            
            int image_left = imageNumber-1;
            if (image_left < 1)
            {
                image_left = 10;
            }
            int image_leftleft = imageNumber - 2;
            if (image_leftleft < 0 )
            {
                image_leftleft = 9;
            }
            if (image_leftleft == 0)
            {
                image_leftleft = 10;
            }

            int image_right = imageNumber+1;
            if (image_right >10)
            {
                image_right = 1;
            }
            int image_rightright = imageNumber + 2;
            if (image_rightright ==11)
            {
                image_rightright = 1;
            }
            if (image_rightright > 11)
            {
                image_rightright = 2;
            }

            pic_slide.ImageLocation = string.Format(@"image\image_0{0}.jpg", imageNumber);
            pic_center.ImageLocation = string.Format(@"image\image_0{0}.jpg", imageNumber);
            picleftleft.ImageLocation = string.Format(@"image\image_0{0}.jpg", image_leftleft);
            pic_left.ImageLocation = string.Format(@"image\image_0{0}.jpg", image_left);
            pic_right.ImageLocation = string.Format(@"image\image_0{0}.jpg", image_right);
            picrightright.ImageLocation = string.Format(@"image\image_0{0}.jpg", image_rightright);
            imageNumber++;
        }

        private void Timer_slide_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void Pic_center_Click(object sender, EventArgs e)
        {

        }

        private void Pic_right_Click(object sender, EventArgs e)
        {

        }

        private void Pic_left_Click(object sender, EventArgs e)
        {

        }
    }
}
