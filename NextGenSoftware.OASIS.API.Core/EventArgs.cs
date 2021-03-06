﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NextGenSoftware.OASIS.API.Core
{
    public class AvatarManagerErrorEventArgs : EventArgs
    {
        public string EndPoint { get; set; }
        public string Reason { get; set; }
        public Exception ErrorDetails { get; set; }

    }

    public class OASISErrorEventArgs : EventArgs
    {
        public string Reason { get; set; }
        public Exception ErrorDetails { get; set; }
    }

    public class ZomesLoadedEventArgs : EventArgs
    {
        public List<IZome> Zomes { get; set; }
    }

    public class HolonLoadedEventArgs : EventArgs
    {
        public IHolon Holon { get; set; }
    }

    public class HolonsLoadedEventArgs : EventArgs
    {
        public List<IHolon> Holons { get; set; }
    }

    public class HolonSavedEventArgs : EventArgs
    {
        public IHolon Holon { get; set; }
    }
    public class ZomeErrorEventArgs : EventArgs
    {
        public string EndPoint { get; set; }
        public string Reason { get; set; }
        public Exception ErrorDetails { get; set; }
        //public HoloNETErrorEventArgs HoloNETErrorDetails { get; set; }
    }


}
