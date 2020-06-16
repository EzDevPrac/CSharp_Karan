using System;

namespace PhotoAlbum
{
    public class BigPhotoAlbum : PhotoAlbum
    {   
        
        private int pages;
        public BigPhotoAlbum()
        {
           pages = 64;
              
        }

        public override int GetNoOfPages(){

            return pages;
        }
    }
}