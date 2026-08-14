from sample_pkg.utils import multiply, is_even

def test_multiply():
    assert multiply(3, 4) == 12

def test_is_even():
    assert is_even(10) is True
