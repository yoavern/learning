using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopol
{
    public partial class BUserControl : UserControl
    {
        private int startedSizeWidth;
        private int startedSizeHeight;
        public BUserControl()
        {
            InitializeComponent();
            startedSizeWidth = this.Size.Width;
            startedSizeHeight = this.Size.Height;
        }
        public BUserControl GetUC()
        {
            return this;
        }
        public Button GetBt()
        {
            return buy;
        }
        public RichTextBox GetRtx1()
        {
            return richTextBox1;
        }
        public RichTextBox GetRtx2()
        {
            return richTextBox2;
        }
        public RichTextBox GetRtx3()
        {
            return richTextBox3;
        }
        public PictureBox GetPicture()
        {
            return pictureBox1;
        }
        public Button GetPlayer1Button()
        {
            return player1;
        }
        public Button GetPlayer2Button()
        {
            return player2;
        }

        public void AdjustingSize(int height, int width)            // התאמת הגודל של הפקדים לגודל הריבוע
        {
                                                            // מציאת ההפרש שבין הגודל ההתחלתי לגודל החדש
            int differenceHeight = startedSizeHeight - height;
            int differenceWidth = startedSizeWidth - width;

            Size bt = new Size(Math.Abs(this.GetBt().Size.Width - differenceWidth), Math.Abs(this.GetBt().Size.Height - differenceHeight));
            Size Rtx1 = new Size(Math.Abs(this.GetRtx1().Size.Width - differenceWidth), Math.Abs(this.GetRtx1().Size.Height - differenceHeight));
            Size Rtx2 = new Size(Math.Abs(this.GetRtx2().Size.Width - differenceWidth), Math.Abs(this.GetRtx2().Size.Height - differenceHeight));
            Size Rtx3 = new Size(Math.Abs(this.GetRtx3().Size.Width - differenceWidth), Math.Abs(this.GetRtx3().Size.Height - differenceHeight));
            Size PictureSize = new Size(Math.Abs(this.GetPicture().Size.Width - differenceWidth), Math.Abs(this.GetPicture().Size.Height - differenceHeight));

            this.GetBt().Size = bt;
            this.GetRtx1().Size = Rtx1;
            this.GetRtx2().Size = Rtx2;
            this.GetRtx3().Size = Rtx3;
            this.GetPicture().Size = PictureSize;

                                                 // changes the x,y of the text Boxes Respectively
            this.GetPicture().Location = new System.Drawing.Point(this.GetPicture().Location.X, Math.Abs(this.GetPicture().Location.Y - differenceHeight));
            this.GetRtx1().Location = new System.Drawing.Point(this.GetRtx1().Location.X, Math.Abs(this.GetRtx1().Location.Y - differenceHeight));
            this.GetRtx2().Location = new System.Drawing.Point(this.GetRtx2().Location.X, Math.Abs(this.GetRtx2().Location.Y - differenceHeight));
            this.GetRtx3().Location = new System.Drawing.Point(this.GetRtx3().Location.X, Math.Abs(this.GetRtx3().Location.Y - differenceHeight));  
        }

    }
}
