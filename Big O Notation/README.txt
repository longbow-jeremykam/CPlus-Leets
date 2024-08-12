
	BIG O NOTATION - How code slows as data grows

1. Describes the performance of algorithms as the amount of data increases
2. Machine independent
3. Ignores smaller operations O(N + 1) = 0(N)

*********************************************** Variants: n = number of data ************************************************************************ 

																					Examples:
																				O(1) - constant time
																					 > random access in array
		Λ																			 > inserting an element into a linkedlist
		|	  O(N!)			O(N²)				 O(Nlog N)						0(N) - linear time
		|		|			   |			   /									 > looping through an array or linkedlist
		|		|			  |				  /									O(log N) - logarithmic time
		|		|			 /  			 /			    O(N)					 > binary search
		|		|			 |	 			/		      /						O(Nlog N) - quasilinear time
		|		|			 |	 		   /		   /							 > quicksort
		|		|			 |			 /		    /								 > mergesort
		|		|			/           /        /									 > heapsort
		|      |           |           /      /									O(N²) - quadratic time
		|      |           |          /    /										 > insertion sort
  time	|      |           |        /   /											 > selection sort
(Steps)	|	   |		   |       / /												 > bubble sort
		|	  |			  |      //												O(N!) - factorial time
		|	  |		     /     /													 > The Travelling Salesman Problem
		|     |    _____/___/_/______________________________________ O(log N)
		|    |   ◜    /  /  /
		|	|  /    / /  /
		|  | /     /  /
		| |/    / /
		|//__/_______________________________________________________ O(1)
		|/  
	 ---|-------------------------------------------------------------->
		|
									data(n)
