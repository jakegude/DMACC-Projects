using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch25Cart.Models
{
    public class ContactViewModel
    {
        public string Email {
            get { return "info@halloweenstore.com"; }
        }
        public string Phone {
            get { return "1-800-123-4567"; }
        }
        public string Address {
            get { return "1234 Main Street, Anytown, USA"; }
        }
        public string[] SocialMediaUrls {
            get {
                return new string[] {
                    "http://www.facebook.com/halloweenstore",
                    "http://www.twitter.com/halloweenstore"
                };
            }
        }
    }
}