#include<iostream>
#include<time.h>
class Stog {
	int V[100];
	int sp;
public:
	Stog() { sp = 0; }
	void push(int x) { V[sp++] = x; }
	int pop() { return V[--sp]; }
	void clear() { sp = 0; }
	int is_empty() { return !sp; }
};
int main() {
	int m, n, povrh = 0, n1, m1;
	time_t t1, t2;
	Stog s1, s2;
	printf("Unesi n: ");
	scanf("%d", &n1);
	m1 = n1 / 2;
	t1 = clock();
	s1.push(n1);
	s2.push(m1);
	do {
		n = s1.pop();
		m = s2.pop();
		if (n == m || m == 0) povrh++;
		else {
			s1.push(n - 1); s2.push(m - 1);
			s1.push(n - 1); s2.push(m);
		}
	} while (!s1.is_empty());
	printf("%d", povrh);
	t2 = clock();
	printf("Vrijeme: %dms", t2 - t1);
	return 0;
}