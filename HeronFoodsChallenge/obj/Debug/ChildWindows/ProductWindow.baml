   M S B A M L   `   `   `  ����N  JHeronFoodsChallenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:HeronFoodsChallenge.ChildWindows HeronFoodsChallenge.ChildWindows  5   	   4    .HeronFoodsChallenge.ChildWindows.ProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:HeronFoodsChallenge.ChildWindows     5   	     � Title$  ProductWindow��5   	   $	��450��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Product Code��6   $��0��6'   $��0��67   �� 5   
   $��Description��6   $��0��6&   $��1��66   �� 5   
   $��Retail Price Inc VAT��6   $��0��6/   $��2��6?   �� 5   
   $��VAT Rate��6   $��0��6#   $��3��63   �� 5   
   $��Barcodes��6   $��0��6#   $��4��63   �� 5   
   -   5         ��Name$ txtProductCode��5      {�.  $��1��6<   $	��300��6L   $��0��6X   �� 5   
   -   5        $ txtProductDescription��5      $��1��61   $	��300��6A   $��1��6M   �� 5   
   -   5        $ RetailPriceIncVAT��5      $��1��6-   $	��300��6=   $��2��6I   �� 5   
   -   5        $ 
txtVATRate��5      $��1��6'   $	��300��67   $��3��6C   �� 5   
   -   5        $ 
txtBarcode��5      $��1��6'   $	��300��67   $��4��6C   �� 5    
   -   5         ��Name$ btnUpdateProduct��5       $y�	Collapsed=�6+   $��Update Product��6B   $��1��6[   $��5��6l   6y   �� 5!   
   -   5        $ btnAddProduct��5!      $y�	Collapsed=�6)   $��Add Product��6@   $��1��6V   $��5��6g   6t   5"      5#      