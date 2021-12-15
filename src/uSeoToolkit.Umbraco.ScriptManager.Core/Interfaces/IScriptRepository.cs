﻿using System.Collections.Generic;
using uSeoToolkit.Umbraco.ScriptManager.Core.Models.Business;

namespace uSeoToolkit.Umbraco.ScriptManager.Core.Interfaces
{
    public interface IScriptRepository
    {
        Script Add(Script script);
        Script Update(Script script);
        void Delete(Script script);

        Script Get(int id);
        IEnumerable<Script> GetAll();
    }
}
