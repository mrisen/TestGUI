   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.WindWpfApp1.Wind  5   	       WpfApp1.Wind.DoctorWindow   5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5	   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5
   	   ,localclr-namespace:WpfApp1.Wind     5   	      MaterialDesignBody#���   5   
     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	     � Title$  Admin��5   	   $	��800��6   $
��1100��6$    � 
ResizeMode$ NoResize=�61    � WindowStartupLocation$ CenterScreen=�6G    � WindowStyle$
 None=�6l    � AllowsTransparency . .��5      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   � -   5        $��2��5      ���	#FF2D7BA8.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$
 Name��5      $	��955��6+   $
��auto��67   ���	#DDFFFFFF$��22(�6\   $��Center=�6j   $��0,4,0,5q�6�   '  !MaterialDesignThemes.Wpf.PopupBox  5       	   PlacementMode$	 BottomAndAlignLeftEdges=�6*   
   	StaysOpen
 .  
�������   PopupContent. 5!      �� .+�5"      �� -   5        $��Помощь��5"   !   62   �� 5#      -   5        $��	О нас��5#   !   61   5$      5%      �� 5'      -   5        $��30��5'      $��30��6%   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�60   $��0q�6a   $��0,0,3,0q�6m   ���	#FF2D7BA8���	#FF2D7BA8
�������.��5(      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowMinimize=�6.   6F   5)      �� 5+      -   5        $��30��5+      $��30��6%   $ Depth3=�60   $��0q�6a   $��0,0,3,0q�6m   ���	#FF2D7BA8���	#FF2D7BA8
�������.��5,        $ AccountSwitch=�6.   6E   5-      �� 5/      -   5        $��30��5/      $��30��6%   $ Depth3=�60   $��0q�6a   $��0,0,3,0q�6m   ���	#FF2D7BA8���	#FF2D7BA8
�������.��50        $ WindowClose=�6.   6C   51      52      53      � 56   
   $��1��6   ��57      �� 58      .��59      �  � Color$ #f6f6f6��6#    � Offset$	 0.0Q�63   � 5:      $
 #fff��6#   $ 1Q�60   5;       5?      �� 5@      $	��150 �6    �� 5A      $	��100 �6    �� 5B      $	��100 �6    �� 5C      $	��100 �6    �� 5D      $	��100 �6    �� 5E      $��* �6     J� Effect 5I      3  -System.Windows.Media.Effects.DropShadowEffect  5J         
BlurRadius$ 20Q�6#      RenderingBias$ Quality=�63      ShadowDepth$ 1Q�6K   .+�5M      � ���	#FF28688D.+�5N      �� $ 
Horizontal=�6   ���	#FF28688D$��Center=�6M   .+�5O      �� $ 
Horizontal=�6!   ���	#FF28688D$ Depth4=�6R   $
��25,0q�6�   .+�5P        $ Hospital=�62   $��80��6B   $��80��6M   
�������6Y   �� 5Q      $��Hospital��6$   $��35(�64   $
��Left=�6B   $��Center=�6]   $��10q�6x   ���	#DDFFFFFF6�   5R      5S      5T      �� 5X      $��1��6   .+�5Y      �� -   5        $��
20,20,0,20q�5Y      $��60��6-   ��6=   Z� ��6k   Z� .��5Z      �� $ 
Horizontal=�6!   $��3,5,3,5q�6:   .+�5[        $ PencilBoxOutline=�62   $��40��6J   $��40��6V   ���	#FFB2B2B2$��0,0,10,0q�6x   �� 5\      $	��200��6$   $��23(�60   $��
Отчет��6>   $��Center=�6K   $��Center=�6f   ���	#FFB2B2B26�   5]      5^      5_      �� 5a      $��2��6   .+�5b      �� -	   5        $��
20,20,0,20q�5b      $��60��6-   ��6=   Z� ��6S   Z� .��5c      �� $ 
Horizontal=�6!   .+�5d      �� $ 
Horizontal=�6%   $��3,5,3,5q�6>   .+�5e        $
 Pill=�66   $��40��6B   $��40��6N   ���	#FFB2B2B2$��0,0,25,0q�6p   �� 5f      $	��200��6(   $��23(�64   $��Лекартсва��6B   $��Center=�6S   $��Center=�6n   ���	#FFB2B2B26�   5g      5h      5i      5j      �� 5k      $��3��6   .+�5l      �� -
   5        $��
20,20,0,20q�5l      $��60��6-   ��6=   Z� ��6S   Z� .��5m      �� $ 
Horizontal=�6!   .+�5n      �� $ 
Horizontal=�6%   $��3,5,3,5q�6>   .+�5o        $ Skull=�66   $��40��6C   $��40��6O   ���	#FFB2B2B2$��0,0,25,0q�6q   �� 5p      $	��200��6(   $��23(�64   $��Болезни��6B   $��Center=�6Q   $��Center=�6l   ���	#FFB2B2B26�   5q      5r      5s      5t      5u      � 5y   
   $��1��6   $��2��6    5z      �� 5{      $	��600 �6    �� 5|      $��* �6    .+�5~      �� $��Hidden=�6   .��5      � .+�5�       � -   5          �Name$ AdFrameNavigation��5�        � NavigationUIVisibility$ Hidden=�67   
����ح�$��20,10,20,10q�6n   5�      5�      �� 5�      $��1��6   .+�5�      �� $ 
Horizontal=�6   $��50, 20, 50,0q�66   .+�5�      �� $��40��6   $	��220��6,   
����������	#FFB2B2B2$��120,10,0,10q�6y   ��6b   Z� .��5�      �� $��Light"�6$   $
��Auto��67   $��22(�6D   $%��Принять пациента��6R   $��Center=�6j   $��Center=�6�   5�      �� 5�      $��40��6   $	��220��6,   
����������	#FFB2B2B2$��120,10,0,10q�6y   ��6b   Z� .��5�      �� $ 
Horizontal=�6%   .+�5�      �� $��Light"�6(   $
��Auto��6;   $��22(�6H   $#��Обновить список��6V   $��Center=�6m   $��Center=�6�   5�      5�      5�      5�      5�      5�      5�      