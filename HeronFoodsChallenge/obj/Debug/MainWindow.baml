   M S B A M L   `   `   `  ����N  JHeronFoodsChallenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HeronFoodsChallengeHeronFoodsChallenge  5   	   $    HeronFoodsChallenge.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:HeronFoodsChallenge     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	   	   �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��1* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� -   5         ��Name$ btnAddProduct��5      $��0��6-   $	��200��6=   $
��Left=�6I   $��Add Product��6d   6z   5      �� 5   
   -   5         ��Name$ ListViewEditProducts��5      $��2��6k   ��. $��Visible=�6�    �� View 5      �� 5      .P�5      ��  �� CellTemplate 5      �� 5      .R�5   "   �� $ btnDeleteProduct��6)   -   5        $��Delete��5   C   6T   5      5!      �� 5"       5#      �� 5$      .R�5%   "   �� $ btnEditProduct��6)   -   5        $
��Edit��5%   A   6P   5&      5(      �� 5)      $��Product Code��6%    �� Width$
 Auto��6;    �� DisplayMemberBinding 6H   �� 	 �� Path$	 ProductCode�
 �� StringFormat$
 D5���� 5*      $��Product Description��6%   $
 Auto��6B    6O   �� $	 ProductDescription��� 5+      $��Retail Price Inc VAT��6%   $
 Auto��6C    6P   �� $	 RetailPriceIncVAT��� 5,      $��VAT Rate��6%   $
 Auto��67    6D   �� $	 VATRate��� 5-      $��Barcodes��6%   $
 Auto��67   -   5        grdVBarodeCol�� 5-   D   �� $	 Barcodes�6s   5/      51      ]� 54   
   .+�55      o� $	��Top=�6   .@�56      m� $��_File��6   .@�57      m� -   5         m�Name$ menuOpen��57      $��_Open��6-   6<   m� 58      -   5        $ menuSave��58      $��_Save��6-   6<   �� 59      m� 5:      -   5        $ menuExit��5:      $��_Exit��6-   6<   5;      5<      5=      5>      5?      