﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfWF
{
    internal class Book
    {
        private int id;
        private string author;
        private string title;
        private string filename;
        private byte[] filedata;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string FileName
        {
            get { return filename; }
            set { filename = value; }
        }

        public byte[] FileData
        {
            get { return filedata; }
            set { filedata = value; }
        }
    }
}