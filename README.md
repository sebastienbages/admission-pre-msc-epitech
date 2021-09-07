 

# Exercise : hidenp

__Executable name__      :          hidenp
__Suggested time__       :          15 minutes


Write a __program__ that takes two strings and displays:
 - 1 followed by '\n' if the first string is hidden in the second string, 
 - otherwise 0 followed by '\n'.

Let s1 and s2 be strings.
s1 is hidden in s2 if each character from s1 can be found in s2, in the same order as in s1.

So:
 - "fgex.;" is hidden in "tyf34gdgf;'ektufjhgdgex.;.;rtjynur6"
 - "abc" is hidden in "2altrb53c.sse"
 - "abc" is not hidden in "btarc"

If there isn't two parameters, the program displays '\n'.

Example 1:
```
(jog@almarita)./hidenp padinton "paqefwtdjetyiytjneytjoeyjnejeyj" | cat -e
1$
(jog@almarita)
```

Example 2:
```
(jog@almarita)./hidenp ddf6vewg64f gtwthgdwthdwfteewhrtag6h4ffdhsd | cat -e
0$
(jog@almarita)
```

Example 3:
```
(jog@almarita)./hidenp "rien" "cette phrase ne cache rien" | cat -e
1$
(jog@almarita)
```

Example 4:
```
(jog@almarita)./hidenp | cat -e
$
(jog@almarita)

```
