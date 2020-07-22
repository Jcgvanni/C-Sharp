using System;
using System.Numerics;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            HugeInteger hG1 = new HugeInteger("");
            HugeInteger hG2 = new HugeInteger("");
            Console.Write("Enter first HugeInteger: ");
            hG1.Input(Console.ReadLine());

            Console.Write("Enter second HugeInteger: ");
            hG2.Input(Console.ReadLine());

            Console.WriteLine("Huge Integer 1: {0}", hG1.ToString());
            Console.WriteLine("Huge Integer 2: {0}", hG2.ToString());

            HugeInteger sum, difference;
            sum = HugeInteger.Add(hG1, hG2);
            Console.WriteLine("Add result: {0}", sum.ToString());
            difference = HugeInteger.Subtract(hG1, hG2);
            Console.WriteLine("Subtract result: {0}", difference.ToString());

            Console.WriteLine("Huge Integer 1 is zero: {0}", hG1.IsZero());
            Console.WriteLine("Huge Integer 2 is zero: {0}", hG2.IsZero());

            Console.WriteLine("HugeInteger 1 is equal to HugeInteger 2: {0}", hG1.IsEqualTo(hG2));
            Console.WriteLine("HugeInteger 1 is not equal to HugeInteger 2: {0}", hG1.IsNotEqual(hG2));
            Console.WriteLine("HugeInteger 1 is greater than HugeInteger 2: {0}", hG1.IsGreaterThan(hG2));
            Console.WriteLine("HugeInteger 1 is less than HugeInteger 2: {0}", hG1.IsLessThan(hG2));
            Console.WriteLine("HugeInteger 1 is greater than or equal to HugeInteger 2: {0}", hG1.IsGreaterThanOrEqualTo(hG2));
            Console.WriteLine("HugeInteger 1 is less than or equal to HugeInteger 2: {0}", hG1.IsLessThanOrEqualTo(hG2));
        }
    }

}
public class HugeInteger
{
    private int[] arr = new int[40];
    private int length;

    public HugeInteger(string number)
    {
        Input(number);
    }

    public HugeInteger()
    {
        Input("");
    }
    public void Input(string num)
    {
        char[] number = num.ToCharArray();
        int i, length = num.Length;

        if (length > 40)
        {
            Console.WriteLine("Number should be less than 40 digits");
            return;
        }

        for (i = 0; i < length; i++)
        {
            array[length - 1 - i] = number[i] - 48;
        }
        for (i = length; i < 40; i++)
        {
            array[i] = 0;
        }
        lengthOfNum = length;
    }


    //get the length of number
    private int lengthOfNum
    {
        get
        {
            return length;
        }
        set
        {
            length = value;
        }
    } //end property

    public int[] array
    {
        get
        {
            return arr;
        }
        set
        {
            arr = value;
        }
    } //end property


    public override string ToString()
    {
        int i;
        string number = "";
        for (i = lengthOfNum - 1; i >= 0; i--)
        {
            number = number + array[i];
        }
        number = number + '\0';
        return number;
    }

    public static HugeInteger Add(HugeInteger hG1, HugeInteger hG2)
    {
        HugeInteger result = new HugeInteger("");
        int l1, l2, i, carry = 0, big;        

        l1 = hG1.lengthOfNum;
        l2 = hG2.lengthOfNum;

        if (l1 > l2)
        {
            big = l1;
        }
        else
        {
            big = l2;
        }

        for (i = 0; i < big; i++)
        {
            result.array[i] = (hG1.array[i] + hG2.array[i] + carry) % 10;
            carry = (hG1.array[i] + hG2.array[i] + carry) / 10;
        }

        result.array[i] = carry;
        if (carry == 0)
        {
            result.lengthOfNum = big;
        }
        else
        {
            result.lengthOfNum = big + 1;
        }
        return result;
    }

    public static HugeInteger Subtract(HugeInteger hG1, HugeInteger hG2)
    {
        HugeInteger result = new HugeInteger("");
        int l1 = 0;
        int l2 = 0;
        int bigPos = 0;
        int big = 0;
        int end = 0;

        l1 = hG1.lengthOfNum;
        l2 = hG2.lengthOfNum;

        if (l1 > l2)
        {
            big = l1;
        }
        else
        {
            big = l2;
        }

        for (int i = 0; i < big; i++)
        {
            result.array[i] = hG1.array[i] - hG2.array[i];
            if (result.array[i] < 0)
            {
                result.array[i] += 10;
                bigPos = i + 1;
                while (bigPos == 0)
                {
                    hG1.array[bigPos] = 9;
                    bigPos++;
                }
                hG1.array[bigPos] -= 1;
            }
            if (result.array[i] != 0)
            {
                end = i;
            }
        }
        result.lengthOfNum = end + 1;
        return result;
    }

    public bool IsZero()
    {
        if (array[lengthOfNum - 1] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsEqualTo(HugeInteger hg)
    {
        int i;
        if (lengthOfNum != hg.lengthOfNum)
            return false;
        for (i = 0; i < lengthOfNum; i++)
        {
            if (array[i] != hg.array[i])
                return false;
        }
        return true;
    }

    public bool IsNotEqual(HugeInteger hg)
    {
        return !IsEqualTo(hg);
    }

    public bool IsGreaterThan(HugeInteger hg)
    {
        int pos = lengthOfNum;
        if (IsEqualTo(hg))
            return false;
        if (lengthOfNum < hg.lengthOfNum)
            return false;
        else if (lengthOfNum > hg.lengthOfNum)
            return true;
        else
        {
            while (array[pos] == hg.array[pos] && pos >= 0)
                pos--;
            if (array[pos] > hg.array[pos])
                return true;
            else
                return false;
        }
    }

    public bool IsLessThan(HugeInteger hg)
    {
        return !IsGreaterThanOrEqualTo(hg);
    }

    public bool IsGreaterThanOrEqualTo(HugeInteger hg)
    {
        if (IsEqualTo(hg) || IsGreaterThan(hg))
            return true;
        else
            return false;
    }

    public bool IsLessThanOrEqualTo(HugeInteger hg)
    {
        if (IsEqualTo(hg) || IsLessThan(hg))
            return true;
        else
            return false;
    }
}//end of class