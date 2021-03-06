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

namespace EyeemMemory.Models
{
    public class EyeemTopicContainer
    {
        public int offset { get; set; }
        public int total { get; set; }
        public int limit { get; set; }
        public List<EyeemTopic> items { get; set; }
    }
}
