﻿using Graduation.App.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Graduation.App.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AppDbContext _context;

        public InitialHostDbBuilder(AppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
