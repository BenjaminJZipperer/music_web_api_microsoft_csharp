using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MUSIC_WEP_API.Models;
namespace MUSIC_WEP_API.Controllers
{
    public class AlbumController : ApiController
    {
        IList<Object> employees = new List<Object>() // räume x byte Speicherplatz für Frau y ein (reporter)
        {

        };

        IList<Album> albums = new List<Album>()
        {
             new Album ()
             { // 4-3-1
                AlbumId = 1,
                Interpret = "Lynyrd Skynyrd",
                AlbumTitle = "Last Rebel",
                NumberTracks = 12,
                Description = "Lynyrd Skynyrd has been one of the most successful American rock bandes\n"+
                              "over the last 40 years of business. Not only did they characterized a\n "+
                              "complete new sound line, but they were also an influenece to many later-\n"+
                              "coming younger rock bands like Queen",

                PicturePath = "lastrebel.jpg"
             },
              new Album ()
             {
                AlbumId = 2,
                Interpret = "Queen",
                AlbumTitle = "Made in Heaven",
                NumberTracks = 0,
                Description = "This album was recorded in 1995, when Queen already were mega rock stars.",
                PicturePath = "madeinheaven.jpg"
             },


           
             // Test album
             new Album ()
             {
                AlbumId = 3,
                Interpret = "U2",
                AlbumTitle = "POP",
                NumberTracks = 12,
                Description = "U2's 12th album was a huge success in the U.S. after many years of less" +
                             " rehearesed attention. Again they came up with a new fresh and experimental"+
                             " sound as last seen on masterpeices like THE UNFORGETABLE FIRE. This album"+
                             " was accompanes with a world-wide tour that was sold-out within a few hours.",
                PicturePath = "pop.jpg"
             },
             // album

             new Album ()
             {
                AlbumId = 4,
                Interpret = "Tom Petty and the Heartbreakers",
                AlbumTitle = "Wildflowers",
                NumberTracks = 15,
                Description = "One of the most underrated albums Tom an d his colleagues made during the 90s." +
                " It came up with 15 solid songs about freedom of life and temptation. This album made it on" +
                " number 3 in the UK and even number 1 in the U.S for 4 weeks.",
                PicturePath = "wildflowers.jpg"
             },
             new Album ()
             {
                AlbumId = 5,
                Interpret = "Alter Bridge",
                AlbumTitle = "Fortress",
                NumberTracks = 12,
                Description = "'One of the best Christian heavy metall albums ever made' (The Rolling Stone)",
                PicturePath = "alterbridge.jpg"
             },
             new Album ()
             {
                AlbumId = 6,
                Interpret = "Nelly Furtado",
                AlbumTitle = "Loose",
                NumberTracks = 13,
                Description = "Featuring Timbaland on song 'maneater' & Juanes on song 'Te Busque'",
                PicturePath = "loose.jpg"
             },
             new Album ()
             {
                AlbumId = 7,
                Interpret = "Brian Littrell",
                AlbumTitle = "Welcome Home",
                NumberTracks = 11,
                Description = "First solo album of former Backstreet Boys singer BRIAN LITTRELL",
                PicturePath = "welcomehome.jpg"
             },
            
             new Album ()
             {
                AlbumId = 8,
                Interpret = "Johnny Cash",
                AlbumTitle = "American Recordings",
                Description ="Johnny Cash said about this album that 'it was '",
                NumberTracks = 13,
                PicturePath = "americanrecordings.jpg"
             }
             // comma am ende - nö
        };
        /* going public 
        public IList<Album> GetAllAlbums()
        {
            //Return list of all s  
            return albums;
        }*/
        public Album GetAlbumDetails(int id)
        {
            //Return a single instance  
            var employee = albums.FirstOrDefault(e => e.AlbumId == id);
            if (employee == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return employee;
        }

        [HttpGet()] // call with ajax in javascript function this code 
        public IHttpActionResult Get()
        {
            IHttpActionResult ret = null;
            List<Album> list = new List<Album>();
            list = albums.ToList(); // cant hear you 
            ret = Ok(list);
            return ret;
        }

        /*
        public String[] GetAllItems()
        {
            //stop processing and throw the HttpResponseException
            var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
            throw new HttpResponseException(response);
            return null;
        }
         * */
    }
   

}
