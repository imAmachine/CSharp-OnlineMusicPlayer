﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OnlineMusicPlayer
{
    public static class Global
    {
        public static Sites webPage = (Sites)Properties.Settings.Default.SelectedWebPage;
        public static Dictionary<Sites, string[]> QueryPatterns = new Dictionary<Sites, string[]>()
        {
            { Sites.hotmo, new string[] {   "search?q=", 
                                            @"<div\sclass=""track__info"".*[\n|\s]*.*[\n|\s]*.*.*[\n|\s]*(.*).*[\n|\s]*.*[\n|\s]*<div class=""track__desc"">(.*)<\/div>[\n|\s]*.*.*[\n|\s]*.*.*[\n|\s]*.*[\n|\s]*<div class=""track__fulltime"">([\d|:]*).*[\n|\s]*.*[\n|\s]*.*[\n|\s]*<a.*href=""(.*\.mp3)""",
                                            @"https://ruv.hotmo.org/"
                                        } 
            },
            {   Sites.sefon, new string[]
                                        {   "search/?q=",
                                            @"<a class="""" data-url=""(.*)"" data-key="".*"">\s*.*\s*.*\s*.*\s*.*\s*.*\s*.*\s*.*\s*.*<mark>(.*)<\/mark>\s*.*\s*.*\s*.*<a href=.*>\s(.*)<",
                                            @"https://ru.sefon.pro/"
                                        }

            }
        };
    }
}
