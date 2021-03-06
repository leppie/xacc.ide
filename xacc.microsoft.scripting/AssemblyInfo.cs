#region License
 /*	  xacc                																											*
 	*		Copyright (C) 2003-2006  Llewellyn@Pritchard.org                          *
 	*																																							*
	*		This program is free software; you can redistribute it and/or modify			*
	*		it under the terms of the GNU Lesser General Public License as            *
  *   published by the Free Software Foundation; either version 2.1, or					*
	*		(at your option) any later version.																				*
	*																																							*
	*		This program is distributed in the hope that it will be useful,						*
	*		but WITHOUT ANY WARRANTY; without even the implied warranty of						*
	*		MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the							*
	*		GNU Lesser General Public License for more details.												*
	*																																							*
	*		You should have received a copy of the GNU Lesser General Public License	*
	*		along with this program; if not, write to the Free Software								*
	*		Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA */
#endregion
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xacc.ComponentModel;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

[assembly: AssemblyTitle("xacc")]
[assembly: AssemblyDescription("Main lib for xacc")]
[assembly:PluginProvider(typeof(Common_PluginLoader))]

sealed class Common_PluginLoader : AssemblyPluginProvider
{
  public override void LoadAll(IPluginManagerService svc)
  {
    ScriptDomainManager sdm = ScriptDomainManager.CurrentManager;

    LanguageProvider langs = sdm.GetLanguageProviderByFileExtension("py");

    Console.WriteLine(langs);

  }
}

