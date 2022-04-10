using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NecklaceModels
{
    public class Pearl
    {
        public int PearlID { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Type { get; set; }

        public override string ToString() => $"{PearlID}: {Color} {Shape}, {Type}";
    }
}
