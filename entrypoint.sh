#!/bin/bash

# Export environment variables from Render's mounted secret files
declare -A secrets=(
  ["StripeKey__TestSecretKey"]="/etc/secrets/STRIPEKEY__TESTSECRETKEY"
  ["AdminMail"]="/etc/secrets/AdminMail"
  ["EmailConfiguration__Password"]="/etc/secrets/EmailConfiguration__Password"
  ["EmailConfiguration__UserName"]="/etc/secrets/EmailConfiguration__UserName"
  ["FMP__APIKEY"]="/etc/secrets/FMP__APIKEY"
  ["JWT__Secret"]="/etc/secrets/JWT__Secret"
  ["Paypal__BaseUrl"]="/etc/secrets/Paypal__BaseUrl"
  ["Paypal__ClientId"]="/etc/secrets/Paypal__ClientId"
  ["Paypal__mode"]="/etc/secrets/Paypal__mode"
  ["Paypal__Secret"]="/etc/secrets/Paypal__Secret"
  ["Paypal__WebUrl"]="/etc/secrets/Paypal__WebUrl"
  ["WebHook__PayPalCallBackUrl"]="/etc/secrets/WebHook__PayPalCallBackUrl"
  ["WebHook__StripeCallBackUrl"]="/etc/secrets/WebHook__StripeCallBackUrl"
  ["ConnectionStrings__ProdDb"]="/etc/secrets/ConnectionStrings__ProdDb"
)

for key in "${!secrets[@]}"; do
  if [ -f "${secrets[$key]}" ]; then
    export "$key"="$(cat "${secrets[$key]}")"
  fi
done

# Start the app
exec dotnet AlpaStock.Api.dll
