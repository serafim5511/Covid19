import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import GridContainer from "components/Grid/GridContainer.js";
import GridItem from "components/Grid/GridItem.js";

import styles from "styles/jss/nextjs-material-kit/pages/componentsSections/basicsStyle.js";
import { Card, CardBody, CardTitle,CardHeader, Container, Row, Col } from "reactstrap";
import Chart from "chart.js";
import { Line, Bar, Doughnut, Radar } from "react-chartjs-2";
const useStyles = makeStyles(styles);

export default function SectionBasics() {
  const classes = useStyles();
  const data = {
    labels: [''],
    datasets: [
      {
        label: '# of Red Votes',
        data: [12],
        backgroundColor: 'rgb(255, 99, 132)',
      },
      {
        label: '# of Blue Votes',
        data: [2],
        backgroundColor: 'rgb(54, 162, 235)',
      },
      {
        label: '# of Green Votes',
        data: [3],
        backgroundColor: 'rgb(75, 192, 192)',
      },
    ],
  };
  
  
  return (
    <div className={classes.sections}>
      <div className={classes.container}>
      
          <GridContainer>
            <GridItem xs={12} sm={4} md={4} lg={3}>
            <CardBody style={{padding:'1rem 1.5rem', background:'#0375B4',color:'white', 'border-radius':'0.375rem' }}>
                    <Row>
                      <div className="col">
                        <CardTitle
                          tag="h5"
                          className="text-uppercase text-muted mb-0">
                          Óbitos
                        </CardTitle>
                        <span className="h2 font-weight-bold mb-0">
                          350.897
                        </span>
                      </div>
                      
                    </Row>
                    
                  </CardBody>
            </GridItem>
            <GridItem xs={12} sm={4} md={4} lg={3}>
            <CardBody style={{padding:'1rem 1.5rem', background:'#0375B4',color:'white', 'border-radius':'0.375rem' }}>
                    <Row>
                      <div className="col">
                        <CardTitle
                          tag="h5"
                          className="text-uppercase text-muted mb-0"
                        >
                          Óbitos
                        </CardTitle>
                        <span className="h2 font-weight-bold mb-0">
                          350.897
                        </span>
                      </div>
                      
                    </Row>
                    
                  </CardBody>
            </GridItem>
            <GridItem xs={12} sm={4} md={4} lg={3}>
            <CardBody style={{padding:'1rem 1.5rem', background:'#0375B4',color:'white', 'border-radius':'0.375rem' }}>
                    <Row>
                      <div className="col">
                        <CardTitle
                          tag="h5"
                          className="text-uppercase text-muted mb-0"
                        >
                          Óbitos
                        </CardTitle>
                        <span className="h2 font-weight-bold mb-0">
                          350.897
                        </span>
                      </div>
                      
                    </Row>
                    
                  </CardBody>
            </GridItem>
            <GridItem xs={12} sm={4} md={4} lg={3}>
            <CardBody style={{padding:'1rem 1.5rem', background:'#0375B4',color:'white', 'border-radius':'0.375rem' }}>
                    <Row>
                      <div className="col">
                        <CardTitle
                          tag="h5"
                          className="text-uppercase text-muted mb-0"
                        >
                          Óbitos
                        </CardTitle>
                        <span className="h2 font-weight-bold mb-0">
                          350.897
                        </span>
                      </div>
                      
                    </Row>
                    
                  </CardBody>
            </GridItem>
            <GridItem xs={12} sm={12} md={6}>
              <div className={classes.title}>
                <h3>Progress Bars</h3>
              </div>
              <Bar data={data}  />

            </GridItem>
            <GridItem xs={12} sm={12} md={6}>
              <div className={classes.title}>
                <h3>Pagination</h3>
              </div>
              <Line data={data} />

            </GridItem>
            <GridItem xs={12} sm={12} md={6}>
              <div className={classes.title}>
                <h3>Pagination</h3>
              </div>
              <Doughnut data={data} />

            </GridItem>
            <GridItem xs={12} sm={12} md={6}>
              <div className={classes.title}>
                <h3>Pagination</h3>
              </div>
              <Radar data={data}  />

            </GridItem>
    
          </GridContainer>
       
      </div>
    </div>
    
  );
}
