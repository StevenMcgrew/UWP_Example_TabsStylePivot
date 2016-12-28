# UWP_Example_TabsStylePivot
This sample customizes the Pivot ControlTemplate and the PivotItem Style, in order to turn it into a Tabs type of control. The Content area of the Pivot control has been made small because it is being used as a toolbar area, but this can be changed back to normal. I made a note in the MainPage xaml at the place where this is changed.

Another option I created was the ability to change the accent color of the Pivot control as the different Tabs are selected. This is done in the code behind on the SelectionChanged event. If you prefer the accent color to stay the same, then just leave this part out. The standard accent color is set at the top of the Page Resources.
