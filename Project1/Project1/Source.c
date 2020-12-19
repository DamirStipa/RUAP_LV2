#include<stdio.h>
#include<time.h>
int binomialCoeff(int n, int k)
{
	if (k > n)
		return 0;
	if (k == 0 || k == n)
		return 1;
	return  binomialCoeff(n - 1, k - 1) + binomialCoeff(n - 1, k);
}

int main() {
	int n;
	time_t t1, t2;
	printf("Unesi n: ");
	scanf("%d", &n);
	t1 = clock();
	printf("%d\n", binomialCoeff(n, n / 2));
	t2 = clock();
	printf("Vrijeme: %dms\n", t2 - t1);
	return 0;
}