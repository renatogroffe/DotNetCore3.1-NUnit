foreach($line in Get-Content dotnet\Temperatura.Testes\TestResults\testResults.trx) 
{
    if($line -match '<Counters total="(?<total>.+)" executed="(?<executed>.+)" passed="(?<passed>.+)" failed="(?<failed>.+)" error="(?<error>.+)" ' )
    {
            $total=$($Matches.total)
            $passed=$($Matches.passed)
            $failed=$($Matches.failed)
            $total
            $passed
            $failed
    }
}