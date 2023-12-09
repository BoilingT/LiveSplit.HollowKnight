﻿#if !Info
using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;
namespace LiveSplit.HollowKnight {
    public class HollowKnightFactory : IComponentFactory {
        public string ComponentName { get { return "Hollow Knight Autosplitter (Boil) v" + this.Version.ToString(); } }
        public string Description { get { return "Autosplitter for Hollow Knight (Boil)"; } }
        public ComponentCategory Category { get { return ComponentCategory.Control; } }
        public IComponent Create(LiveSplitState state) { return new HollowKnightComponent(state); }
        public string UpdateName { get { return this.ComponentName; } }
        public string UpdateURL { get { return "https://raw.githubusercontent.com/ShootMe/LiveSplit.HollowKnight/master/"; } }
        public string XMLURL { get { return this.UpdateURL + "Components/LiveSplit.HollowKnight.Updates.xml"; } }
        public Version Version { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
    }
}
#endif