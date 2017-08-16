﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlipDrop.Data
{
    public class RegionsRepository
    {
        public IEnumerable<SelectListItem> GetRegions(string iso3)
        {
            using (var context = new ApplicationDbContext())
            {
                IEnumerable<SelectListItem> regions = context.Regions.AsNoTracking()
                    .OrderBy(n => n.RegionNameEnglish)
                    .Where(n => n.Iso3 == iso3)
                    .Select(n =>
                       new SelectListItem
                       {
                           Value = n.RegionCode,
                           Text = n.RegionNameEnglish
                       }).ToList();
                return new SelectList(regions, "Value", "Text");
            }
        }
    }
}