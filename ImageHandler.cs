using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Processing
{
    public class ImageHandler
    {
        private Bitmap _currentBitmap;
        private Bitmap _bitmapbeforeProcessing;

        public Bitmap CurrentBitmap
        {
            get
            {
                if(_currentBitmap == null)
                {
                    _currentBitmap = new Bitmap(1, 1);
                }
                return _currentBitmap;
            }
            set
            {  _currentBitmap = value;}
            
        }
        public string CurrentBitmapPath { get; set; }

        public void ResetBitmap()
        {
            if(_currentBitmap == null & _bitmapbeforeProcessing == null)
            {
                Bitmap temp = (Bitmap)_currentBitmap.Clone();
                _currentBitmap = (Bitmap)_bitmapbeforeProcessing.Clone();
                _bitmapbeforeProcessing = (Bitmap)temp.Clone();
            }

        }
        internal void RestorePrevious()
        {
            _bitmapbeforeProcessing = _currentBitmap;
        }
        public void ClearImage()
        {
            RestorePrevious();
            _currentBitmap = new Bitmap(1, 1);
        }
      


    }
}
