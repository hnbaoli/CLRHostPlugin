﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CLROBS;

namespace CSharpSamplePlugin
{
    class SampleSettingsPane : AbstractWPFSettingsPane
    {
        public override void ApplySettings()
        {
            throw new NotImplementedException();
        }

        public override void CancelSettings()
        {
            throw new NotImplementedException();
        }

        public override UIElement CreateUIElement()
        {
            return new SampleSettingsPaneControl();
        }
        
        public override bool HasDefaults()
        {
            return false;
        }

        public override void SetDefaults()
        {
            throw new NotImplementedException();
        }
    }
}
