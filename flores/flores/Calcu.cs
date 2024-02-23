class Calculator
{
    private int firstNum, secondNum;

    public Calculator(int firstNum, int secondNum)
    {
        this.firstNum = firstNum;
        this.secondNum = secondNum;
    }
    public void setFirstNum(int firstNum)
    {
        this.firstNum = firstNum;
    }
    public void setSecondNum(int secondNum)
    {   `
        this.secondNum = secondNum;
    }
    public int getFirstNum()
    {
        return firstNum;
    }
    public int getSecondNum()
    {
        return secondNum;
    }

    public int getSum()
    {
        return getFirstNum() + getSecondNum();
    }
    public int getDifference()
    {
        return getFirstNum() - getSecondNum();
    }
    public int getProduct()
    {
        return getFirstNum() * getSecondNum();
    }
    public int getQuotient()
    {
        return getFirstNum() / getSecondNum();
    }
}