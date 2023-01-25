﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProgramAssignWebAPI.Models.DTO
{
    public class EditResourceDto
    {
        public int VAMID { get; set; }
        public string TechTrack { get; set; }
        public string ResourceName { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }
        public string Manager { get; set; }
        public string SME { get; set; }
        public string? SMEStatus { get; set; }
        public string? ProgramStatus { get; set; }
    }
}
