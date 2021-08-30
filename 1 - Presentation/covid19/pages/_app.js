import React from "react";
import App from "next/app";
import Head from "next/head";
import Component from "pages/Index.js";

import "styles/scss/nextjs-material-kit.scss?v=1.2.0";


export default class MyApp extends App {  
  render() {

    return (
      <React.Fragment>
        <Head>
          <meta
            name="viewport"
            content="width=device-width, initial-scale=1, shrink-to-fit=no"
          />
          <title>Covid-19</title>
        </Head>
        <Component  />
      </React.Fragment>
    );
  }
}
