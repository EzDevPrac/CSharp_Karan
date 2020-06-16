using System;


namespace PhotoAlbum
{
    public class PhotoAlbum
    {
        private int NoOfPages;


       public PhotoAlbum(){

           NoOfPages = 16;
       }

       public PhotoAlbum(int _pages)
       {
           NoOfPages = _pages;
       }
        public virtual int GetNoOfPages(){

            return NoOfPages;
        }
        
    }
}