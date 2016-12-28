# UWP_Example_TabsStylePivot
![capture1](https://cloud.githubusercontent.com/assets/24802383/21515025/c06d0042-cc80-11e6-9aa1-e6f83bfcffe1.PNG)
![capture2](https://cloud.githubusercontent.com/assets/24802383/21515026/c06d46ec-cc80-11e6-9013-2b4e916d9fbb.PNG)
![capture3](https://cloud.githubusercontent.com/assets/24802383/21515024/c06caf7a-cc80-11e6-98fa-1d260a52c6ae.PNG)
![capture4](https://cloud.githubusercontent.com/assets/24802383/21515027/c06fc9bc-cc80-11e6-9654-85bc2a56ecae.PNG)
This sample customizes the Pivot ControlTemplate and the PivotItem Style, in order to turn it into a Tabs type of control. The Content area of the Pivot control has been made small because it is being used as a toolbar area, but this can be changed back to normal. I made a note in the MainPage xaml at the place where this is changed.

Another option I created was the ability to change the accent color of the Pivot control as the different Tabs are selected. This is done in the code behind on the SelectionChanged event. If you prefer the accent color to stay the same, then just leave this part out. The standard accent color is set at the top of the Page Resources.
