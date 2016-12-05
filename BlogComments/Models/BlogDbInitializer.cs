using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BlogComments.Models
{
    public class BlogDbInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        /*
        protected override void Seed(BlogContext db)
        {
            db.Posts.Add(new Post {
                    Date = new DateTime(2011, 6, 10),
                    Title = "Aenean varius elit et odio vehicula maximus",
                    PostTxt = "Aenean varius elit et odio vehicula maximus. Curabitur ac commodo neque. Nulla sed nulla ut odio pellentesque fringilla id vitae leo. Vivamus urna nibh, convallis non massa eget, ullamcorper aliquet nunc. Sed ante lorem, sollicitudin ut luctus et, dignissim eu est. Duis cursus leo purus, a viverra enim hendrerit sed. Pellentesque tempus vitae nisi non commodo. Nullam sed venenatis mauris. Sed et pharetra diam. Aliquam consequat, quam et ultricies consectetur, nulla tortor mollis leo, eu suscipit dolor ante sollicitudin velit."
                });
            db.Posts.Add(new Post {
                    Date = new DateTime(2015, 5, 17),
                    Title = "Vestibulum placerat",
                    PostTxt = "Vestibulum placerat fermentum elementum. Sed nec mi pellentesque mauris ultrices semper in at dui. Mauris auctor elit tellus, ac pellentesque ipsum bibendum in"
            });
            db.Posts.Add(new Post {
                    Date = new DateTime(2016, 2, 23),
                    Title = "Nunc quis massa eget est lobortis auctor sed ac ligula",
                    PostTxt = "Nunc quis massa eget est lobortis auctor sed ac ligula. Maecenas ac eros quis elit convallis ultrices. Vestibulum ac consequat risus. Sed eu dolor eu justo ultrices vehicula quis vel mauris."
            });

            base.Seed(db);
        }
        */
    }
}