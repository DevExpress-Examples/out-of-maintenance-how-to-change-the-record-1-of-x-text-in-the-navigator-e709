using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;

namespace LocalizedText {
    public class MyLocalizer : Localizer {
        public override string GetLocalizedString(StringId id) {
            switch(id) {
                case StringId.NavigatorTextStringFormat: return "Item {0} of {1}";
            }
            return base.GetLocalizedString(id);
        }
    }
}
