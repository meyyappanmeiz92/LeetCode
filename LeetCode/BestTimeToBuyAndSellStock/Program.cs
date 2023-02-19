// See https://aka.ms/new-console-template for more information
/// <summary>
/// Brute Force -> Two For Loops,
/// Optimum Solution -> Assign first element of the array to BuyPrice and maxProfit to 0,
/// loop from 2nd element to end of the array,
/// Check price[i] < buyPrice, assign buyPrice = price[i]
/// else maxProfit = Math.Max(maxProfit, price[i] - buyPrice),
/// return maxProfit.
/// </summary>

int[] prices = {7, 1, 5, 3, 6, 4};
MaxProfit(prices);

int MaxProfit(int[] prices)
{
    int buyPrice = prices[0];   
    int maxProfit = 0;

    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] < buyPrice)
        {
            buyPrice = prices[i];
        }
        else
        {
            maxProfit = Math.Max(maxProfit, prices[i] - buyPrice);
        }
    }

    return maxProfit;
}
