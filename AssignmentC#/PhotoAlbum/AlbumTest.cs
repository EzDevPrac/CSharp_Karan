using System;

namespace PhotoAlbum
{
    public class AlbumTest
    {
        BigPhotoAlbum _BigPhotoAlbum;
        PhotoAlbum _photoAlbum,_photoAlbum1;  
         public AlbumTest(BigPhotoAlbum bigPhoto,PhotoAlbum photoAlbum,PhotoAlbum photoAlbum1){
           
           _BigPhotoAlbum = bigPhoto;
           _photoAlbum = photoAlbum;
           _photoAlbum1 = photoAlbum1;
              
         }
        static void Main(string[] args)
        {
            AlbumTest al = new AlbumTest(new BigPhotoAlbum(),new PhotoAlbum(24),new PhotoAlbum());
            
            Console.WriteLine(al._photoAlbum.GetNoOfPages());
            Console.WriteLine(al._photoAlbum1.GetNoOfPages());
            Console.WriteLine(al._BigPhotoAlbum.GetNoOfPages());
        }
    }
}
