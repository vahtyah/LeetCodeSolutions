<h1><a href="https://leetcode.com/problems/number-of-1-bits?envType=study-plan-v2&envId=top-interview-150">0191. Number of 1 Bits</a></h1>

![Difficulty: Easy](https://img.shields.io/badge/Easy-46c6c2)

---

<p>Given a positive integer <code>n</code>, write a function that returns the number of <span data-keyword="set-bit">set bits</span> in its binary representation (also known as the <a href="http://en.wikipedia.org/wiki/Hamming_weight" target="_blank">Hamming weight</a>).</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

><p><strong>Input:</strong> <span class="example-io">n = 11</span></p>
>
><p><strong>Output:</strong> <span class="example-io">3</span></p>
>
><p><strong>Explanation:</strong></p>
>
><p>The input binary string <strong>1011</strong> has a total of three set bits.</p>

<p><strong class="example">Example 2:</strong></p>

><p><strong>Input:</strong> <span class="example-io">n = 128</span></p>
>
><p><strong>Output:</strong> <span class="example-io">1</span></p>
>
><p><strong>Explanation:</strong></p>
>
><p>The input binary string <strong>10000000</strong> has a total of one set bit.</p>

<p><strong class="example">Example 3:</strong></p>

><p><strong>Input:</strong> <span class="example-io">n = 2147483645</span></p>
>
><p><strong>Output:</strong> <span class="example-io">30</span></p>
>
><p><strong>Explanation:</strong></p>
>
><p>The input binary string <strong>1111111111111111111111111111101</strong> has a total of thirty set bits.</p>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 &lt;= n &lt;= 2<sup>31</sup> - 1</code></li>
</ul>

<p>&nbsp;</p>
<strong>Follow up:</strong> If this function is called many times, how would you optimize it?