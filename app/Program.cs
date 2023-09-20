var print = (object msg) => Console.Write(msg + "\n");

var getNumberOfLuckyTickets = (int dimension, int numberCount) => {
	numberCount = (numberCount - numberCount % 2) / 2;
	var sumsCount = new long [(dimension - 1)* numberCount + 1];
	foreach(var iter in (long)Math.Pow(dimension,numberCount)){
		long buff = iter;
		long index = 0;
		while(buff > 0){
			index += buff % dimension;
			buff /= dimension;
		}
		sumsCount[index]+=1;
	}
	long count = 0;
	foreach(var i in sumsCount) count += i * i;
return count;
};
print(getNumberOfLuckyTickets(13,13) * 13);
static class longIncrementalExtention{
	public static IEnumerator<long> GetEnumerator(this long n){
		for(int i = 0; i < n;i++) yield return i;
	}
}


