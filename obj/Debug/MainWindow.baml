   M S B A M L   `   `   `  ����F  BIDParserWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:IDParserWPFIDParserWPF  5   	       IDParserWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:IDParserWPF     5   	     � Title$  ID Converter��5   	   $	��350��6   $	��525��6+   $y�Visible=�67   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF4B4B4B��6    � Offset$ 0Q�6-   � 5      $ 	#FFEEE8E8��6   $ 1Q�6-   5      .��5      � -   5         �Name$ 	basicGrid��5      ���	#FF315478 � ColumnDefinitions 5   
   �� 5      $
��167* �6   �� 5      $
��247* �6   �� 5      $��0* �6   �� 5      $
��103* �6   .+�5   
   �� -   5         ��Name$ browseButton��5      $��Browse��6'   $
��Left=�68   $��
207,76,0,0q�6S   $	��Top=�6g   $	��100��6   $��1��6�   $��3��6�   $��20��6�   $��0q�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF4B4B4B��6#   � 5      $ 	#FFEEE8E8��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$ inputFilenameTextbox��5      $
��Left=�60   $��20��6K   $��	37,76,0,0q�6W   	 �� TextWrapping$
	 Wrap=�6j   $	��Top=�6�   $	��326��6�   $��2��6�   ��6~   �� *InputFileName+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ outputFilenameTextbox��5      $
��Left=�61   $��20��6L   $��
37,130,0,0q�6X   $
	 Wrap=�6l   $	��Top=�6�   $	��326��6�   $��2��6�   ��6�   �� *OutputFileName+$
 TwoWay=�6�   �� 5    
   -   5        $ convertButton��5       $��Convert��6(   $
��Left=�6:   $��
37,172,0,0q�6U   $	��Top=�6i   $	��100��6�   $��20��6�   $��0q�6�   ��5!      �� 5"      $ 0.5,1&�6&   $ 0.5,0&�67   .��5#      � $ 	#FF4B4B4B��6#   $ 0Q�65   � 5$      $ 	#FFEEE8E8��6#   $ 1Q�65   5%      5'      �� 5(   
   -   5         ��Name$ 	textBlock��5(      $
��Left=�6'   $��	37,47,0,0q�6B   $
��Wrap=�6U   $��File to convert��6i   $	��Top=�6�   $��16��6�   $	��100��6�   �� 5)   
   -   5        $ 
textBlock1��5)      $
��Left=�6(   $��
37,101,0,0q�6C   $
��Wrap=�6W   $��Output file��6k   $	��Top=�6~   $��16��6�   $��57��6�   �� 5*   
   -   5        $ messageBlock��5*      $
��Left=�6*   $��
37,204,0,0q�6E   $
��Wrap=�6Y   $	��Top=�6�   $��95��6�   $	��306��6�   $��2��6�   ��6m   �� *	Message+6�   5+      5,      