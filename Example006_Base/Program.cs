﻿int a = 1;
int b = 4;
int c = 8;
int d = 2;
int e = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
