﻿using KenticoInspector.Core.Models;
using System.Collections.Generic;

namespace KenticoInspector.Core.Repositories.Interfaces
{
    public interface ISiteRepository : IRepository
    {
        Site GetSite(Instance instance, int siteId);

        IList<Site> GetSites(Instance instance);
    }
}