﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Data
{
    public class Picture
    {
        public int Id { get; set; }

        public string ImageThumbnail { get; set; }

        public byte[] UpdatedPicture { get; set; }
    }
}