   M S B A M L   `   `   `  ����>  :RPG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:RPGRPG  5   	       RPG.CreateNewCharacter   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:RPG     5   	     � Title$  Create Your Hero��5   	   $��323.866��6"   $��515.294��63   ���	#FFD4D2D2.��5	      � 
�������.+�5
   
   �� -   5         ��Name$ NewCharacterLabel��5
      $4��.Enter a name and choose a class for your hero:��6+   $��Center=�6d   $��106,38,118,227q�6�   $��Center=�6�   $��Calibri)�6�   $��14(�6�   $	��283��6�   $��28��6�   �� 5   
   -   5         ��Name$ NameCharacter��5      $��Center=�6)   $��23��6F   $��168,79,182,191q�6R    �� TextWrapping$
 Wrap=�6j   $��Center=�6~   $	��157��6�   $��Calibri)�6�   �� 5   
   -   5         ��Name$ Okay_Button��5      $��Create��6&   $��Center=�67   $��205,0,227,50q�6T   $��Bottom=�6j   $��75��6�   $��Calibri)�6�   6�   � 5   
   $��Center=�6   $	��106��6,   $��185,107,206,80q�69   $��Center=�6Q   $	��116��6l   .+�5      	� -   5         	�Name$ paladinButton��5       	� 	GroupName$ ClassChoice��61   $��Paladin��6I   $
��Left=�6[   $��	10,70,0,0q�6v   $	��Top=�6�    d� 	IsChecked$
 TrueY�6�   $��Calibri)�6�   $��16(�6�   6�   	� 5      -   5        $ 
mageButton��5      $ ClassChoice��6.   $
��Mage��6F   $
��Left=�6U   $��	10,30,0,0q�6p   $	��Top=�6�   $
 TrueY�6�   $��Calibri)�6�   $��16(�6�   6�   	� 5      -   5        $ thiefButton��5      $ ClassChoice��6/   $��Thief��6G   $
��Left=�6W   $��	10,50,0,0q�6r   $	��Top=�6�   $
 TrueY�6�   $��Calibri)�6�   $��16(�6�   6�   	� 5      -   5        $ warriorButton��5      $ ClassChoice��61   $��Warrior��6I   $
��Left=�6[   $��
10,10,0,81q�6v   $	��Top=�6�   $
 TrueY�6�   $��Calibri)�6�   $��16(�6�   6�   5      �� 5   
   -   5         ��Name$ 
ClassImage��5      $
��Left=�6$   $	��130��6?   $��	27,95,0,0q�6L   $	��Top=�6_   $	��123��6w   $(��"/RPG;component/Sprites/Warrior.png��6�   $
��Fill=�6�   5      5      