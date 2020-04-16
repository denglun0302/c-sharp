#include<stdio.h>
#include<Windows.h>
int fib1(int x)
{
	if (x <= 2)
	{
		return 1;
	}
	else return  fib1(x - 1) + fib1(x- 2);
}
int  fib2(int x)
{
	int sum;
	int first;
	int second;
	first = second = 1;
	while (x > 2)
	{
		sum = first + second;
		first = second;
		second = sum;
		x--;
	}
	return sum;
}

int main()
{
	int n=5, m=5;
	n = fib1(n);
	m = fib2(m);
	return 0;
	system("pause");
}