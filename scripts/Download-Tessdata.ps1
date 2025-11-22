# Download Tesseract trained data
# Compatible with PowerShell 5.1 and PowerShell Core 7+

param(
    [string]$TessdataPath = "tessdata",
    [string]$Language = "eng"
)

$ErrorActionPreference = "Stop"

$tessdataUrl = "https://github.com/tesseract-ocr/tessdata/raw/main/$Language.traineddata"
$targetFile = Join-Path $TessdataPath "$Language.traineddata"

Write-Host "checking for tessdata folder..." -ForegroundColor Cyan

if (-not (Test-Path $TessdataPath)) {
    Write-Host "creating tessdata folder: $TessdataPath" -ForegroundColor Yellow
    New-Item -ItemType Directory -Path $TessdataPath -Force | Out-Null
}

if (Test-Path $targetFile) {
    Write-Host "tessdata already exists: $targetFile" -ForegroundColor Green
    Write-Host "skipping download" -ForegroundColor Green
    exit 0
}

Write-Host "downloading tesseract trained data..." -ForegroundColor Cyan
Write-Host "source: $tessdataUrl" -ForegroundColor Gray
Write-Host "target: $targetFile" -ForegroundColor Gray

try {
    if ($PSVersionTable.PSVersion.Major -ge 6) {
        Invoke-WebRequest -Uri $tessdataUrl -OutFile $targetFile -UseBasicParsing
    } else {
        [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
        Invoke-WebRequest -Uri $tessdataUrl -OutFile $targetFile -UseBasicParsing
    }
    
    $fileSize = (Get-Item $targetFile).Length / 1MB
    Write-Host "download completed successfully" -ForegroundColor Green
    Write-Host "file size: $([math]::Round($fileSize, 2)) MB" -ForegroundColor Gray
}
catch {
    Write-Host "download failed: $_" -ForegroundColor Red
    exit 1
}
