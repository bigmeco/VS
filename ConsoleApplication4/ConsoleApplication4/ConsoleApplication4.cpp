// ConsoleApplication4.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <iterator>
#include <algorithm>






	std::ostream& operator<< (std::ostream& stream, const std::vector<int>& vec)
	{
		std::copy(vec.begin(), vec.end(), std::ostream_iterator<int>(std::cout, " "));
		return stream;
	}



	int main()
	{
		std::vector<int> vec(std::istream_iterator<int>(std::cin), (std::istream_iterator<int>()));
		std::cout << "Source: " << vec << std::endl;
		vec.erase(std::unique(vec.begin(), vec.end()), vec.end());
		std::cout << "Result: " << vec << std::endl;
	}
  


