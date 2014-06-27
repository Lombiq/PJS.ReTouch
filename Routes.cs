﻿using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;

namespace PJS.ReTouch {
    public class Routes : IRouteProvider {
        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes() {
            return new[] {
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route("ValidateUserName",
                        new RouteValueDictionary {
                            {"area", Constants.RoutesAreaName},
                            {"controller", "Validate"},
                            {"action", "ValidateUserName"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", Constants.RoutesAreaName}
                        },
                        new MvcRouteHandler())
                },
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route("ValidateUserEmail",
                        new RouteValueDictionary {
                            {"area", Constants.RoutesAreaName},
                            {"controller", "Validate"},
                            {"action", "ValidateUserEmail"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", Constants.RoutesAreaName}
                        },
                        new MvcRouteHandler())
                },
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route("ValidateUserNameEmail",
                        new RouteValueDictionary {
                            {"area", Constants.RoutesAreaName},
                            {"controller", "Validate"},
                            {"action", "ValidateUserNameEmail"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", Constants.RoutesAreaName}
                        },
                        new MvcRouteHandler())
                }
            };
        }
    }
}