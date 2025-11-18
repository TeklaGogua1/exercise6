from labraries import py_lab as p

a, b, c, d, e, f = 5, 3, 7, 4, 2, 10
x, y, z, is_admin = True, False, True, False


# 1) Worked Example
expected1 = (a + b * c) > (d - e) and x or y
actual1 = p.or_func(
    p.and_func(
        p.greater_than(
            p.add(a, p.multiply(b, c)),
            p.subtract(d, e)
        ),
        x
    ),
    y
)
print(expected1, actual1)


# 2)
expected2 = (a - b) * (c + d) <= e and z and not x
actual2 = p.and_func(p.less_equal(p.multiply(p.subtract(a, b), p.add(c, d)), e), p.and_func(z, p.not_func(x)))
print(expected2, actual2)

# 3)
expected3 = (a + b + c) % d == 0 or (f > e and is_admin)
actual3 = p.or_func(p.equal(p.mod(p.add(a, p.add(b, c)), d), 0), p.and_func(p.greater_than(f, e), is_admin))
print(expected3, actual3)

# 4)
expected4 = not (x or y) and (a * a > b * c)
actual4 = p.and_func(p.not_func(p.or_func(x, y)), p.greater_than(p.multiply(a, a), p.multiply(b,c)))
print(expected4, actual4)
