﻿using System.Text.RegularExpressions;
namespace WebApplication1.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsValidGroupName()
        {
            return Regex.Match(GroupName, @"\D*-\d*-\d\d").Success;
        }
    }
}

