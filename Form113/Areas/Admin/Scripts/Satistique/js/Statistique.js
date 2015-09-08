$(function () {
    Graph();
    //GraphV2();
    $("#min").change(Verif);
    $("#max").change(Verif);
    $("#ButtonModifGraph").click(Graph);
});

function Verif()
{
    console.log("toto");
    var min = $("#min").val();
    var max = $("#max").val();
    if(min > max)
    {
        $("#min").val(max);
    }
}

function Graph() {
    $("#graph").html("");
    "use strict";
    /*global d3*/

    // Constantes du graphe
    var width = 800,
        height = 700,
        margin = { top: 70, right: 40, bottom: 150, left: 40 },
        w = width - margin.left - margin.right,
        h = height - margin.top - margin.bottom,

        // DÃ©finition de la zone du graphique
        svg = d3.select("#graph")
                    .append("svg")
                        .attr("width", width)
                        .attr("height", height),

        graph = svg.append("g")
                    .attr("transform", "translate(" + margin.left + ", " + margin.top + ")"),

        // Des donnÃ©es d'Ã©chelle
        // En x donnÃ©es discrÃ¨tes par bandes ce qui convient trÃ¨s bien aux barres verticales
        x = d3.scale.ordinal()
                .rangeRoundBands([0, w], 0.3),

        // En y donnÃ©es linÃ©aires qui correspondent Ã  la hauteur des barres
        y = d3.scale.linear()
                .range([h, 0]),

		// Les couleurs des barres du graphique
		color = d3.scale.category20(),

        // Les axes
        xAxis = d3.svg.axis()
            .scale(x)
            .orient("bottom"),

        yAxis = d3.svg.axis()
            .scale(y)
            .orient("left")
            .ticks(1)
            .tickFormat(""),

        // La grille avec juste les lignes horizontales
        yGrid = d3.svg.axis()
            .scale(y)
            .orient("left")
            .ticks(5)
            .tickSize(-w, 0, 0)
            .tickFormat(d3.format("d")),

        title = graph.append("g")
            .attr("class", "title"),

        labels = graph.append("g")
            .attr("class", "labels");


    title.append("text")
        .attr("x", (w / 2))
        .attr("y", -margin.top / 2)
        .attr("text-anchor", "middle")
        .style("font-size", "22px")
        .text("Suivi des visites de produits");
    // Chargement et manipulation des donnÃ©es
    //
    d3.json('/Statistique/GetJSONStatistique/' + $("#min").val() + "-" + $("#max").val(), function (error, data) {
        // Tout ce qui dÃ©pend des donnÃ©es doit Ãªtre placÃ© dans cette fonction de callback
        // Mise en correspondance de l'intervalle des donnÃ©es discrÃ¨tes avec la place dÃ©finie par x
        x.domain(data.map(function (d) { return d.Nom; }));
        // Idem mais pour les valeurs continues 
        y.domain([0, d3.max(data, function (d) { return d.NbVis; })]);

        graph.append("g")
            .attr("class", "x axis")
            .attr("transform", "translate(0," + h + ")")
            .call(xAxis)
            .selectAll("text")
                .style("text-anchor", "end")
                .attr("dx", "-.8em")
                .attr("dy", ".15em")
                .attr("transform", "rotate(-65)");

        graph.append("g")
            .attr("class", "y axis")
            .call(yAxis);

        graph.append("g")
            .attr("class", "grid")
            .call(yGrid);

        labels.append("text")
            .attr("transform", "rotate(-90)")
            .attr("y", -2 * margin.left / 3)
            .attr("x", -h / 2)
            //.attr("dy", ".100em")
            .style("text-anchor", "middle")
            .text("Nombre de visites");

        graph.selectAll("rect")
            .data(data)
                .enter().append("rect")
                    .attr("x", function (d) { return x(d.Nom); })

/* -------------------------------------------------------------------------*/
                    .attr("width", 0)
/* -------------------------------------------------------------------------*/

                    .attr("y", h)
                    .attr("height", 0)
                    .attr("fill", function (d) { return color(d.Nom); })

                    .transition()

/* -------------------------------------------------------------------------*/
                        .attr("width", x.rangeBand())
/* -------------------------------------------------------------------------*/

                        .attr("y", function (d) { return y(d.NbVis); })
                        .attr("height", function (d) { return h - y(d.NbVis); })
                        .duration(3000)
                        .delay(100);
    })
}

//function GraphV2()
//{

//    var margin = { top: 20, right: 20, bottom: 30, left: 40 },
//        width = 960 - margin.left - margin.right,
//        height = 500 - margin.top - margin.bottom;

//    var x0 = d3.scale.ordinal()
//        .rangeRoundBands([0, width], .1);

//    var x1 = d3.scale.ordinal();

//    var y = d3.scale.linear()
//        .range([height, 0]);

//    var color = d3.scale.ordinal()
//        .range(["#98abc5", "#8a89a6", "#7b6888", "#6b486b", "#a05d56", "#d0743c", "#ff8c00"]);

//    var xAxis = d3.svg.axis()
//        .scale(x0)
//        .orient("bottom");

//    var yAxis = d3.svg.axis()
//        .scale(y)
//        .orient("left")
//        .tickFormat(d3.format(".2s"));

//    var svg = d3.select("body").append("svg")
//        .attr("width", width + margin.left + margin.right)
//        .attr("height", height + margin.top + margin.bottom)
//      .append("g")
//        .attr("transform", "translate(" + margin.left + "," + margin.top + ")");

//    d3.json('/Statistique/GetJSONStatistique2/' + $("#min").val() + "-" + $("#max").val(), function (error, data) {
//    d3.csv("data.csv", function (error, data) {
//        if (error) throw error;

//        var ageNames = d3.keys(data[0]).filter(function (key) { return key !== "State"; });

//        data.forEach(function (d) {
//            d.ages = ageNames.map(function (name) { return { name: name, value: +d[name] }; });
//        });

//        x0.domain(data.map(function (d) { return d.State; }));
//        x1.domain(ageNames).rangeRoundBands([0, x0.rangeBand()]);
//        y.domain([0, d3.max(data, function (d) { return d3.max(d.ages, function (d) { return d.value; }); })]);

//        svg.append("g")
//            .attr("class", "x axis")
//            .attr("transform", "translate(0," + height + ")")
//            .call(xAxis);

//        svg.append("g")
//            .attr("class", "y axis")
//            .call(yAxis)
//          .append("text")
//            .attr("transform", "rotate(-90)")
//            .attr("y", 6)
//            .attr("dy", ".71em")
//            .style("text-anchor", "end")
//            .text("Nombre de Visite");

//        var state = svg.selectAll(".state")
//            .data(data)
//          .enter().append("g")
//            .attr("class", "g")
//            .attr("transform", function (d) { return "translate(" + x0(d.State) + ",0)"; });

//        state.selectAll("rect")
//            .data(function (d) { return d.ages; })
//          .enter().append("rect")
//            .attr("width", x1.rangeBand())
//            .attr("x", function (d) { return x1(d.name); })
//            .attr("y", function (d) { return y(d.value); })
//            .attr("height", function (d) { return height - y(d.value); })
//            .style("fill", function (d) { return color(d.name); });

//        var legend = svg.selectAll(".legend")
//            .data(ageNames.slice().reverse())
//          .enter().append("g")
//            .attr("class", "legend")
//            .attr("transform", function (d, i) { return "translate(0," + i * 20 + ")"; });

//        legend.append("rect")
//            .attr("x", width - 18)
//            .attr("width", 18)
//            .attr("height", 18)
//            .style("fill", color);

//        legend.append("text")
//            .attr("x", width - 24)
//            .attr("y", 9)
//            .attr("dy", ".35em")
//            .style("text-anchor", "end")
//            .text(function (d) { return d; });

//    });

//}