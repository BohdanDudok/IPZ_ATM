   M S B A M L   `   `   `  ����I  EIPZ_ATM_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:IPZ_ATM_ClientIPZ_ATM_Client  5   	       IPZ_ATM_Client.Main   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:IPZ_ATM_Client     5   	     � Title$  Банкомат��5   	   $	��561��6   $	��800��6'    � 
ResizeMode$ NoResize=�63    � WindowStyle$ ThreeDBorderWindow=�6I    � WindowStartupLocation$ CenterScreen=�6j   .��5	      � #��� ��6   $��0,0,0,-3q�6X   .+�5
   
   �� $
��Left=�6   $	��218��6,   $��
176,56,0,0q�69   $	��Top=�6M   $	��434��6e   
�������.+�5      �� $/��)Виберіть спосіб входу!��6   $��Center=�65   $	��Top=�6R   $	��146��6j   $��26��6v    �� Left$	 138��6�   
 �� Top$ 26��6�   �� 5      $ ��Адміністратор��6   $��29��6,   $ 10��68   $	 115��6I   $	��108��6Z   �� 5      $��Клієнт��6   $��29��6%   $ 10��61   $	 163��6B   $	��108��6S   5      �� 5   
   -   5         ��Name$ B��5      $��1��6   $
��Left=�6(   $��246,293,0,0q�6C   $	��Top=�6X   $��62��6p   $��48��6{   6�   �� 5   
   -   5        $��2��5      $
��Left=�6   $��313,293,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $��3��5      $
��Left=�6   $��384,293,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $��4��5      $
��Left=�6   $��246,346,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $��5��5      $
��Left=�6   $��313,346,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $��6��5      $
��Left=�6   $��384,346,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $��7��5      $
��Left=�6   $��246,399,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $��8��5      $
��Left=�6   $��313,399,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -	   5        $��9��5      $
��Left=�6   $��384,399,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -
   5        $��0��5      $
��Left=�6   $��313,452,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $��Зкид��5      $
��Left=�6    $��608,293,0,0q�6;   $	��Top=�6P   $��62��6h   $��48��6s   6   �� 5   
   -   5        $��Відміна��5      $
��Left=�6#   $��608,346,0,0q�6>   $	��Top=�6S   $��62��6k   $��48��6v   6�   �� 5   
   -   5        $��Ввід��5      $
��Left=�6    $��608,399,0,0q�6;   $	��Top=�6P   $��62��6h   $��48��6s   6   �� 5   
   -   5        $�� ��5      $
��Left=�6   $��
109,56,0,0q�67   $	��Top=�6K   $��62��6c   $��48��6n   6z   �� 5   
   -   5        $�� ��5      $
��Left=�6   $��109,109,0,0q�68   $	��Top=�6M   $��62��6e   $��48��6p   6|   �� 5   
   -   5        $�� ��5      $
��Left=�6   $��109,162,0,0q�67   $	��Top=�6L   $��62��6d   $��48��6o   6{   �� 5   
   -   5        $�� ��5      $
��Left=�6   $��109,215,0,0q�67   $	��Top=�6L   $��62��6d   $��48��6o   6{   �� 5    
   -   5        $�� ��5       $
��Left=�6   $��
615,56,0,0q�67   $	��Top=�6K   $��62��6c   $��48��6n   6z   �� 5!   
   -   5        $�� ��5!      $
��Left=�6   $��615,109,0,0q�67   $	��Top=�6L   $��62��6d   $��48��6o   6{   �� 5"   
   -   5        $�� ��5"      $
��Left=�6   $��615,162,0,0q�67   $	��Top=�6L   $��62��6d   $��48��6o   6{   �� 5#   
   -   5        $�� ��5#      $
��Left=�6   $��615,215,0,0q�67   $	��Top=�6L   $��62��6d   $��48��6o   6{   5$      5%      