import React from "react";
import classNames from "classnames";
import { makeStyles } from "@material-ui/core/styles";
import Header from "components/Header/Header.js";
import Footer from "components/Footer/Footer.js";
import GridContainer from "components/Grid/GridContainer.js";
import GridItem from "components/Grid/GridItem.js";
import Parallax from "components/Parallax/Parallax.js";
import SectionBasics from "pages-sections/Components-Sections/SectionBasics.js";
import styles from "styles/jss/nextjs-material-kit/pages/components.js";

const useStyles = makeStyles(styles);

async function  teste() {
  return await fetch('http://localhost:5000/api/Get')
  .then((respostaDoServer) => {
    if (respostaDoServer.ok) {
      return respostaDoServer.json();
    }

    throw new Error('Deu problema');
  })
  .then((respostaEmObjeto) => respostaEmObjeto);

}


export  default  function Index() {
  console.log(teste().p);
const classes = useStyles();
  return (
    <div>
      <Header
        brand="Covid"
        fixed
        color="transparent"
        changeColorOnScroll={{
          height: 400,
          color: "white",
        }}
      />
      <Parallax image="/img/nextjs_header.jpg">
        <div className={classes.container}>
          <GridContainer>
            <GridItem>
              <div className={classes.brand}>
                <h1 className={classes.title}>Covid-19</h1>
                <h3 className={classes.subtitle}>
                  Painel de casos de doença pelo coronavírus 2021 (COVID-19)
                </h3>
              </div>
            </GridItem>
          </GridContainer>
        </div>
      </Parallax>

      <div className={classNames(classes.main, classes.mainRaised)}>
        <SectionBasics />
       
      </div>
      <Footer />
    </div>
  );
}


