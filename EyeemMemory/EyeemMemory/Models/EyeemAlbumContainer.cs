﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EyeemMemory.Models
{
    [DataContract]
    public class EyeemAlbumContainer
    {
        [DataMember]
         public int offset {get; set;}
        [DataMember] 
        public int limit {get; set;}
        [DataMember]
         public int total {get; set;}
        [DataMember]
         public List<EyeemAlbum> items {get; set;}
    }
}
