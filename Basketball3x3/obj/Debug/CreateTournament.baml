   M S B A M L   `   `   `  ����H  DBasketball3x3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Basketball3x3Basketball3x3  5   	   $    Basketball3x3.CreateTournament   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Basketball3x3     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � 
ResizeMode$ NoResize=�6?    � WindowStyle$
 None=�6U    � Title$ CreateTournament��5   	   $	��450��6"   $	��800��6/   .��5	      � ���#fab578.+�5   
   �� $
��Left=�6   $	��336��6+   $��-118,226,0,-112q�68   $	��Top=�6Q   $	��476��6i   $%��images/splashscreen/splash1.png��6u   �� 5   
   -   5         ��Name$ label_Tournament��5      $��Create tournament��6*   $��Century Gothic)�6F   $��25(�6b   $
��Left=�6p   $��
268,10,0,0q�6�   $	��Top=�6�   �� 5   
   $��Tournament name:��6   $��Century Gothic)�6+   $��17(�6G   $
��Left=�6U   $��	42,56,0,0q�6p   $	��Top=�6�   �� 5   
   -   5         ��Name$ tb_tournamentName��5      $
��Left=�6-   $��Century Gothic)�6H   $��17(�6d   $��23��6r   $��	42,92,0,0q�6~    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��318��6�   �� 5   
   $��
Entry fee:��6   $��Century Gothic)�6%   $��17(�6A   $
��Left=�6O   $��
42,140,0,0q�6j   $	��Top=�6~   �� 5   
   -   5        $ tb_entryFee��5      $
��Left=�6'   $��Century Gothic)�6B   $��17(�6^   $��22��6l   $��133,144,0,0q�6x   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   �� 5   
   $��Select team:��6   $��Century Gothic)�6'   $��17(�6C   $
��Left=�6Q   $��
42,190,0,0q�6l   $	��Top=�6�   �� 5   
   -   5         ��Name$ cb_selectTeam��5      $
��Left=�6*   $��Century Gothic)�6E   $��17(�6a   $��23��6o   $��
42,226,0,0q�6{   $	��Top=�6�   $	��318��6�   �� 5   
   -   5        $��Create team��5      $��Century Gothic)�6'   $��17(�6C   $
��Left=�6Q   $��162,193,0,0q�6l   $	��Top=�6�   $	��198��6�   6�   �� 5   
   -   5        $��Add team��5      $��Century Gothic)�6$   $��17(�6@   $
��Left=�6N   $��133,268,0,0q�6i   $	��Top=�6~   $	��120��6�   $��40��6�   6�   �� 5   
   -   5        $��Create prize��5      $��Century Gothic)�6(   $��17(�6D   $
��Left=�6R   $��133,330,0,0q�6m   $	��Top=�6�   $	��120��6�   $��40��6�   6�   �� 5   
   $��Teams/Players��6   $��Century Gothic)�6(   $��17(�6D   $
��Left=�6R   $��
419,56,0,0q�6m   $	��Top=�6�   �� 5   
   -	   5         ��Name$ lb_tournamentTeams��5      $
��Left=�6.   $��Century Gothic)�6I   $��17(�6e   $	��117��6s   $��
419,92,0,0q�6�   $	��Top=�6�   $	��268��6�   �� 5   
   -
   5        $��Remove
selected��5      $��Century Gothic)�6/   $��17(�6K   $
��Left=�6Y   $��703,126,0,0q�6t   $	��Top=�6�   $��75��6�   $��50��6�   6�   �� 5   
   $��Prizes��6   $��Century Gothic)�6!   $��17(�6=   $
��Left=�6K   $��419,217,0,0q�6f   $	��Top=�6{   �� 5   
   -   5        $ 	lb_prizes��5      $
��Left=�6%   $��Century Gothic)�6@   $��17(�6\   $	��117��6j   $��419,253,0,0q�6w   $	��Top=�6�   $	��268��6�   �� 5   
   -   5        $��Remove
selected��5      $��Century Gothic)�6/   $��17(�6K   $
��Left=�6Y   $��703,287,0,0q�6t   $	��Top=�6�   $��75��6�   $��50��6�   6�   �� 5   
   -   5        $��Create tournament��5      $��Century Gothic)�6-   $��17(�6I   $
��Left=�6W   $��296,390,0,0q�6r   $	��Top=�6�   $	��188��6�   $��50��6�   6�   �� 5    
   -   5        $��Go back��5       $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   $��75��6i   $��17(�6t   6�   5"      5#      