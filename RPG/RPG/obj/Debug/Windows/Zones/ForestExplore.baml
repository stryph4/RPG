   M S B A M L   `   `   `  ����>  :RPG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RPG.WindowsRPG.Windows  5   	       RPG.Windows.ForestExplore   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RPG.Windows     5   	     � Title$  Forest��5   	   $	��450��6   $	��800��6%   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $
��396* �6   �� 5      $
��397* �6   .+�5   
   � -   5         �Name$ 
Background��5      $
��Left=�6#   $	��269��6>   $	��Top=�6K   $	��783��6c   $��2��6o   ��5      �� 5       �� ImageSource$ Backgrounds/forest.png��6   .+�5      �� -   5         ��Name$ 
ClassImage��5      $
��Left=�6(   $	��155��6C   $��
92,114,0,0q�6P   $	��Top=�6d   $	��161��6|   $(��"/RPG;component/Sprites/Warrior.png��6�   $
��Fill=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      5      � 5   
   $��Center=�6   $��74��6,   $��217,269,215.333,0q�68   $	��Top=�6S   $	��361��6k   $��2��6w   .+�5      �� -   5         ��Name$ ExploreButton��5      $��	Explore
��6,   $
��Left=�6H   $��30,0,0,0q�6c   $��Center=�6u   $��85��6�   $��54��6�    �� IsCancel . $��Calibri)�6�   $��16(�6�   $
��Bold"�6�   6�   �� 5      -   5        $ LeaveButton��5      $��Leave
��6*   $��Right=�6?   $��0,0,30,0q�6[   $��Center=�6m   $��85��6�   $��54��6�    � Cursor$
 Hand��6�   $��Calibri)�6�   $��16(�6�   $
��Bold"�6�   6�   5      5      5      