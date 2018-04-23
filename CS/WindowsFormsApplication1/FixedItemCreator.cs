using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace WindowsFormsApplication1
{
    public class FixedItemCreator
    {
        List<BarItem> fixedItems = new List<BarItem>();
        RibbonControl Ribbon;

        public FixedItemCreator(RibbonControl ribbon) 
        {
            fixedItems = new List<BarItem>();
            Ribbon = ribbon;
            Ribbon.SelectedPageChanged += new EventHandler(Ribbon_SelectedPageChanged);
        }

        void Ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            List<BarItem> absentItems = new List<BarItem>();
            foreach (BarItem fixedItem in fixedItems)
            {
                bool founded = false;
                foreach (RibbonPageGroup group in Ribbon.SelectedPage.Groups)
                {

                    foreach (BarItemLink itemLink in group.ItemLinks)
                    {
                        if (itemLink.Item == fixedItem)
                        {
                            founded = true;
                        }

                    }
                }
                if (!founded)
                {
                    absentItems.Add(fixedItem);
                }
            }

            foreach (BarItem absentItem in absentItems)
            {
                RibbonPageGroup patternGroup = (absentItem.Links[0].LinkedObject as RibbonPageGroupItemLinkCollection).PageGroup;
                RibbonPageGroup currentGroup = null;
                foreach (RibbonPageGroup group in Ribbon.SelectedPage.Groups)
                {
                    if (group.Text == patternGroup.Text)
                    {
                        currentGroup = group;
                        break;
                    }
                }
                if (currentGroup == null)
                {
                    currentGroup = new RibbonPageGroup();
                    currentGroup.Text = patternGroup.Text;
                    if (patternGroup.Page.Groups.IndexOf(patternGroup) >= Ribbon.SelectedPage.Groups.Count)
                    {
                        Ribbon.SelectedPage.Groups.Add(currentGroup);
                    }
                    else
                    {
                        Ribbon.SelectedPage.Groups.Insert(patternGroup.Page.Groups.IndexOf(patternGroup), currentGroup);
                    }
                    
                }
                currentGroup.ItemLinks.Add(absentItem);
            }
        }

        public void AddItem(BarItem item)
        {
            if (!fixedItems.Contains(item))
            {
                fixedItems.Add(item);
            }        
        }
    }
}
